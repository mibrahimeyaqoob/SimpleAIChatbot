namespace SimpleAIChatbot
{
    partial class SimpleAIChatbot
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userInputTextBox = new TextBox();
            conversationHistoryRichTextBox = new RichTextBox();
            sendButton = new Button();
            modelComboBox = new ComboBox();
            SuspendLayout();
            // 
            // userInputTextBox
            // 
            userInputTextBox.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userInputTextBox.Location = new Point(192, 415);
            userInputTextBox.Name = "userInputTextBox";
            userInputTextBox.Size = new Size(548, 34);
            userInputTextBox.TabIndex = 0;
            userInputTextBox.KeyDown += userInputTextBox_KeyDown;
            // 
            // conversationHistoryRichTextBox
            // 
            conversationHistoryRichTextBox.Dock = DockStyle.Top;
            conversationHistoryRichTextBox.Font = new Font("Yu Gothic UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            conversationHistoryRichTextBox.Location = new Point(0, 0);
            conversationHistoryRichTextBox.Name = "conversationHistoryRichTextBox";
            conversationHistoryRichTextBox.ReadOnly = true;
            conversationHistoryRichTextBox.Size = new Size(882, 394);
            conversationHistoryRichTextBox.TabIndex = 1;
            conversationHistoryRichTextBox.Text = "";
            conversationHistoryRichTextBox.TextChanged += conversationHistoryRichTextBox_TextChanged;
            // 
            // sendButton
            // 
            sendButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sendButton.Location = new Point(746, 400);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(124, 49);
            sendButton.TabIndex = 2;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // modelComboBox
            // 
            modelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modelComboBox.DropDownWidth = 500;
            modelComboBox.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modelComboBox.FormattingEnabled = true;
            modelComboBox.IntegralHeight = false;
            modelComboBox.Items.AddRange(new object[] { "provider-4/gpt-4.1", "provider-4/deepseek-v3", "provider-4/claude-3.7-sonnet", "provider-4/gemini-2.5-pro-preview-05-06", "provider-1/deepseek-ai/DeepSeek-R1", "provider-1/deepseek-ai/DeepSeek-R1-0528", "provider-1/deepseek-ai/DeepSeek-V3", "provider-1/gpt-4.1-2025-04-14", "Llama-4-Maverick-17B-128E", "provider-3/deepseek-r1", "provider-3/gpt-4o", "provider-3/gpt-4o-2024-11-20" });
            modelComboBox.Location = new Point(12, 418);
            modelComboBox.Name = "modelComboBox";
            modelComboBox.Size = new Size(174, 31);
            modelComboBox.TabIndex = 3;
            modelComboBox.SelectedIndexChanged += modelComboBox_SelectedIndexChanged;
            // 
            // SimpleAIChatbot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(882, 453);
            Controls.Add(modelComboBox);
            Controls.Add(sendButton);
            Controls.Add(conversationHistoryRichTextBox);
            Controls.Add(userInputTextBox);
            MaximumSize = new Size(900, 500);
            MinimumSize = new Size(900, 500);
            Name = "SimpleAIChatbot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SimpleAIChatbot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userInputTextBox;
        private RichTextBox conversationHistoryRichTextBox;
        private Button sendButton;
        private ComboBox modelComboBox;
    }
}
