using System;
using System.Windows.Forms;

namespace GraphicalProgrammingLanguage
{
    public partial class MainForm : Form
    {
        private TextBox programTextBox;
        private TextBox commandTextBox;
        private Button runButton;
        private Button syntaxCheckButton;
        private RichTextBox resultTextBox;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Create and configure GUI components
            programTextBox = new TextBox
            {
                Multiline = true,
                Size = new System.Drawing.Size(400, 200),
                Location = new System.Drawing.Point(10, 10)
            };

            commandTextBox = new TextBox
            {
                Size = new System.Drawing.Size(400, 30),
                Location = new System.Drawing.Point(10, 220)
            };

            runButton = new Button
            {
                Text = "Run",
                Size = new System.Drawing.Size(195, 30),
                Location = new System.Drawing.Point(10, 260)
            };
            runButton.Click += RunButton_Click; // Add event handler

            syntaxCheckButton = new Button
            {
                Text = "Syntax Check",
                Size = new System.Drawing.Size(195, 30),
                Location = new System.Drawing.Point(215, 260)
            };
            syntaxCheckButton.Click += SyntaxCheckButton_Click;

            resultTextBox = new RichTextBox
            {
                Size = new System.Drawing.Size(400, 400),
                Location = new System.Drawing.Point(430, 10),
            };

            // Set up the form
            this.Text = "Graphical Programming Language";
            this.Size = new System.Drawing.Size(855, 470);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Controls.Add(programTextBox);
            this.Controls.Add(commandTextBox);
            this.Controls.Add(runButton);
            this.Controls.Add(syntaxCheckButton);
            this.Controls.Add(resultTextBox);
        }

        private void RunButton_Click(object sender, EventArgs e)
        {

        }

        private void SyntaxCheckButton_Click(object sender, EventArgs e)
        {

        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
