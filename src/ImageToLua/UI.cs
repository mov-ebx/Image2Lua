using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToLua
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void UI_Load(object sender, EventArgs e)
        {
            SyntaxHighlighter syntaxHighlighter = new SyntaxHighlighter(ScriptBox);
            syntaxHighlighter.StringStyle = new TextStyle(new SolidBrush(Color.FromArgb(149, 199, 149)), null, FontStyle.Regular);
            syntaxHighlighter.CommentStyle = new TextStyle(new SolidBrush(Color.FromArgb(153, 153, 153)), null, FontStyle.Regular);
            syntaxHighlighter.NumberStyle = new TextStyle(new SolidBrush(Color.FromArgb(249, 145, 87)), null, FontStyle.Regular);
            syntaxHighlighter.KeywordStyle = new TextStyle(new SolidBrush(Color.FromArgb(204, 153, 204)), null, FontStyle.Regular);
            syntaxHighlighter.FunctionsStyle = new TextStyle(new SolidBrush(Color.FromArgb(99, 148, 197)), null, FontStyle.Regular);
            ScriptBox.SyntaxHighlighter = syntaxHighlighter;
            ScriptBox.Text = "-- Select an image!";
        }

        #region Mouse Events

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Draggable(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #region Button Mouse Events

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(22, 83, 145);
                button.NotifyDefault(false);
            }
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(134, 134, 134);
                button.NotifyDefault(false);
            }
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
                button.NotifyDefault(false);
            }
        }

        private void Mouse_Up(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(134, 134, 134);
                button.NotifyDefault(false);
            }
        }

        #endregion

        #endregion

        #region Button Click Events

        private void Clear_Click(object sender, EventArgs e)
        {
            ScriptBox.Text = "-- Select an image!";
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ScriptBox.Text);
        }

        #region Top bar

        private void Exit_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Image To Lua Converter

        private Bitmap ResizeBitmap(Bitmap bitmap)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            if (width <= maxWidthAdjuster.Value && height <= maxHeightAdjuster.Value)
            {
                return bitmap;
            }
            double aspectRatio = (double)width / height;
            if (width > maxWidthAdjuster.Value)
            {
                width = (int)maxWidthAdjuster.Value;
                height = (int)Math.Round(width / aspectRatio);
            }
            if (height > maxHeightAdjuster.Value)
            {
                height = (int)maxHeightAdjuster.Value;
                width = (int)Math.Round(height * aspectRatio);
            }
            return new Bitmap(bitmap, new Size(width, height));
        }

        private void Open_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = Application.StartupPath;
            if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
            {
                ScriptBox.Text = "-- Processing image...\n-- Please be patient.";
                String script = "local colors = {";
                Bitmap bitmap = ResizeBitmap(new Bitmap(ofd.FileName));

                int i = 0;
                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        Color color = bitmap.GetPixel(x, y);
                        ScriptBox.Text = $"-- Processing image...\n-- Please be patient.\n\n-- {i}/{bitmap.Height*bitmap.Width} complete";
                        ScriptBox.Refresh();
                        i++;
                        script += $"Color3.fromRGB({color.R},{color.G},{color.B}),";
                    }
                }
                script = script.Trim(',') + "}\n\n"+$"local width = {bitmap.Size.Width}\nlocal height = {bitmap.Size.Height}" +"\n\nlocal grid = Instance.new(\"UIGridLayout\", script.Parent)\ngrid.CellSize = UDim2.new(1,0,1/height,0)\ngrid.CellPadding = UDim2.new(0,0,0,0)\ngrid.SortOrder = Enum.SortOrder.LayoutOrder\n\nfor i,v in colors do\n    local chunk = math.floor(i/width)\n    local pixel\n    if script.Parent:FindFirstChild(\"Chunk\"..tostring(chunk)) then\n        pixel = Instance.new(\"Frame\", script.Parent:FindFirstChild(\"Chunk\"..tostring(chunk)))\n    else\n        local chunkI = Instance.new(\"Frame\", script.Parent)\n        chunkI.Name = \"Chunk\"..tostring(chunk)\n        chunkI.BorderSizePixel = 0\n        local list = Instance.new(\"UIListLayout\",chunkI)\n        list.FillDirection = Enum.FillDirection.Horizontal\n        list.SortOrder = Enum.SortOrder.LayoutOrder\n        pixel = Instance.new(\"Frame\", chunkI)\n        game:GetService(\"RunService\").Stepped:Wait()\n    end\n\n    pixel.BackgroundColor3 = v\n    pixel.BorderSizePixel = 0\n    pixel.Size = UDim2.new(1/width,0,1,0)\n    if i%50 == 0 then\n        game:GetService(\"RunService\").Stepped:Wait()\n    end\nend";
                ScriptBox.Text = script;
            }
        }

        #endregion

        #endregion

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click the \"Open Image\" button, and select a\nPNG. It'll generate a script from that image.\n\nTo use the scripts generated by by this tool,\nyou must have a Frame instance, and have\nthe script inside of it, it'll automate making\nthe image, which will scale to the size of\nthe frame its in.", $"Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x20000);
        }

    }
}
