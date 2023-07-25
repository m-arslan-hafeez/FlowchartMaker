using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FlowchartMaker
{
    public partial class Form1 : Form
    {
        private List<FlowchartElement> elements = new List<FlowchartElement>();
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.White;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            btnRemoveLast.Click += btnRemoveLast_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var element in elements)
            {
                DrawFlowchartElement(e.Graphics, element);

                foreach (var connectedElement in element.Connections)
                {
                    Point start = new Point(element.Position.X + 50, element.Position.Y + 50);
                    Point end = new Point(connectedElement.Position.X + 50, connectedElement.Position.Y);
                    e.Graphics.DrawLine(Pens.Black, start, end);
                }
            }    
        }

        private void DrawFlowchartElement(Graphics graphics, FlowchartElement element)
        {
            Rectangle rect = new Rectangle(element.Position, new Size(70, 35));
            graphics.DrawRectangle(Pens.Black, rect);
            graphics.FillRectangle(Brushes.LightGray, rect);

            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            graphics.DrawString(element.NodeText, Font, Brushes.Black, rect, sf); 
        }

        private bool ShowInputDialogIfNeeded(out string inputText)
        {
            inputText = string.Empty;
            bool shouldShowInputDialog = elements.Any(element => string.IsNullOrWhiteSpace(element.NodeText));

            if (shouldShowInputDialog)
            {
                using (var inputDialog = new InputDialog())
                {
                    inputDialogShown = true;
                    if (inputDialog.ShowDialog() == DialogResult.OK)
                    {
                        inputText = inputDialog.InputText.Trim();
                    }
                    inputDialogShown = false; 
                }
            }

            return shouldShowInputDialog;
        }

        private FlowchartElement lastClickedElement = null;
        private bool inputDialogShown = false;



        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (btnAddStart.Checked)
            {

                if (!inputDialogShown)
                {
                    if (ShowInputDialogIfNeeded(out string inputText))
                    {
                        elements.Add(new FlowchartElement
                        {
                            NodeText = inputText.Trim(),
                            Position = e.Location
                        });

                        pictureBox1.Invalidate();
                    }
                }

                //txtNodeText.Location = new Point(e.X, e.Y);
                //using (var inputDialog = new InputDialog())
                //{
                //    if (inputDialog.ShowDialog() == DialogResult.OK)
                //    {
                //        elements.Add(new FlowchartElement
                //        {
                //            NodeText = inputDialog.InputText.Trim(),
                //            Position = e.Location
                //        });

                //        pictureBox1.Invalidate();
                //    }
                //}
            }

            if (e.Button == MouseButtons.Left && ModifierKeys == Keys.Control && lastClickedElement != null)
            {
                FlowchartElement clickedElement = elements.FirstOrDefault(element =>
                    
                e.X >= element.Position.X && e.X <= element.Position.X + 70 &&
                    e.Y >= element.Position.Y && e.Y <= element.Position.Y + 35);

                if (clickedElement != null && clickedElement != lastClickedElement)
                {
                    lastClickedElement.Connections.Add(clickedElement);
                    pictureBox1.Invalidate();
                }
            }
            else
            {
                lastClickedElement = elements.LastOrDefault();
            }
        }
        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            if (elements.Count > 0)
            {
                elements.RemoveAt(elements.Count - 1);
                pictureBox1.Invalidate();
            }
            else {
                MessageBox.Show("No Node is added!");
            }
        }

        private void btnAddStart_CheckedChanged(object sender, EventArgs e)
        {
            if (btnAddStart.Checked)
            {
                btnAddStart.BackColor = Color.LightGreen; 
            }
            else
            {
                btnAddStart.BackColor = SystemColors.Control;
            }
        }
    }
}
