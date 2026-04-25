using System.Windows.Forms;
using System.Linq;

namespace Plumber_Game.Utilities
{
    /// <summary>
    /// Utility class for common control operations.
    /// </summary>
    public static class ControlHelper
    {
        /// <summary>
        /// Sets the visibility of all UI boundary boxes (used for no-clip visualization).
        /// </summary>
        public static void SetUIBoundariesVisibility(this Control parent, bool visible)
        {
            for (int i = 1; i <= 10; i++)
            {
                var control = parent.Controls.Find($"pictureBoxUi{i}", false).FirstOrDefault();
                if (control != null)
                {
                    control.Visible = visible;
                }
            }
        }

        /// <summary>
        /// Safely casts a sender object to a PictureBox and executes an action if successful.
        /// </summary>
        public static bool TryGetPictureBox(object sender, out PictureBox pictureBox)
        {
            pictureBox = sender as PictureBox;
            return pictureBox != null;
        }
    }
}
