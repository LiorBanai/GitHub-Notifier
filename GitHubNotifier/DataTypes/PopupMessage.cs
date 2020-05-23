using System.Drawing;

namespace GitHubNotifier.DataTypes
{
    public class PopupMessage
    {
        public string Caption { get; set; }
        public string Text { get; set; }
        public Image Image { get; set; }

        public PopupMessage()
        {
            this.Caption = "";
            this.Text = "";
        }
    }
}
