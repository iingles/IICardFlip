using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IICardFlip
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        ///   Determine whether a card face or back is showing
        ///   Flip the card to have the opposite of what is showing (front or back)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFlip_Clicked(object sender, EventArgs e)
        {
            /*
             * Create a new Button instance, assign it to 
             * the sender parameter so we can get the attributes from the front end
            */
            Button selectedBtn = (Button)sender;


            /* 
             * If the selectedBtn text is equal to "Show Card Face",
             * show the card face, hide the card back
            */
            if (selectedBtn.Text == "Show Card Face")
            {
                // Set the button text to "Show Card Back"
                BtnFlip.Text = "Show Card Back";
                // Change the face visibility to true
                ImgCardFace.IsVisible = true;
                // Change the back visibility to false
                ImgCardBack.IsVisible = false;
            }

            // Else, do the opposite - show the card back, hide the card face
            else
            {
                // Set the button text to "Show Card Face"
                BtnFlip.Text = "Show Card Face";
                // Change the face visibility to false
                ImgCardFace.IsVisible = false;
                // Change the back visibility to true
                ImgCardBack.IsVisible = true;
            }

        }
    }
}
