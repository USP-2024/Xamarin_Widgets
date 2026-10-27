using System;
using System.Collections.Generic;

namespace WidgetDemoApp
{
    public partial class MainPage : ContentPage
    {
        // Counter for the Like button (starts at zero)
        private int likeCount = 0;

        public MainPage()
        {
            InitializeComponent();

            // Data for the horizontal skill list
            SkillsView.ItemsSource = new List<string>
            {
                "C#", "MAUI", ".NET", "Git", "XAML", "SQL"
            };
        }

        // Like button: increase the counter and update the button text
        private void OnLikeClicked(object sender, EventArgs e)
        {
            likeCount++;
            LikeButton.Text = $"Like ({likeCount})";
        }

        // Message button: show an alert dialog
        private async void OnMessageClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Message", "Your message has been sent!", "OK");
        }

        // Entry: runs when the user presses Done on the keyboard
        private void OnCommentCompleted(object sender, EventArgs e)
        {
            CommentLabel.Text = string.IsNullOrWhiteSpace(CommentEntry.Text)
                ? string.Empty
                : $"Your comment: {CommentEntry.Text}";
            CommentEntry.Text = string.Empty;
        }

        // Switch: update the availability text when toggled
        private void OnAvailableToggled(object sender, ToggledEventArgs e)
        {
            AvailabilityLabel.Text = e.Value ? "Available for projects" : "Not available";
        }
    }
}
