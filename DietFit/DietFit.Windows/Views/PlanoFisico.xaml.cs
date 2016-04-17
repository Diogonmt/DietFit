using DietFit.Common;
using DietFit.Controllers;
using DietFit.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Split Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234234

namespace DietFit.Views
{
    /// <summary>
    /// A page that displays a group title, a list of items within the group, and details for
    /// the currently selected item.
    /// </summary>
    public sealed partial class PlanoFisico : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        private UtilizadorInfoController controller;
        private Utilizador user;

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        private void textBoxex44_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        private void textBoxex44_Copy1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        public PlanoFisico()
        {
            this.InitializeComponent();

            // Setup the navigation helper
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;

            // Setup the logical page navigation components that allow
            // the page to only show one pane at a time.
            this.navigationHelper.GoBackCommand = new DietFit.Common.RelayCommand(() => this.GoBack(), () => this.CanGoBack());
            this.itemListView.SelectionChanged += itemListView_SelectionChanged;

            // Start listening for Window size changes 
            // to change from showing two panes to showing a single pane
            Window.Current.SizeChanged += Window_SizeChanged;
            this.InvalidateVisualState();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            controller = (UtilizadorInfoController)e.Parameter;

            user = controller.getUser();
            this.txt_Nome.Text = user.getPnome();
            this.txt_Mail.Text = user.getMail();
            this.txt_Peso.Text = user.getPeso().ToString();
            this.txt_Objetivo.Text = user.getObjetivo();
            this.textBlockmm.Text = user.getMassaM().ToString();
            this.textBlockmg.Text = user.getMassaG().ToString();
        }

        void itemListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.UsingLogicalPageNavigation())
            {
                this.navigationHelper.GoBackCommand.RaiseCanExecuteChanged();
            }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="Common.NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            // TODO: Assign a bindable group to Me.DefaultViewModel("Group")
            // TODO: Assign a collection of bindable items to Me.DefaultViewModel("Items")

            if (e.PageState == null)
            {
                // When this is a new page, select the first item automatically unless logical page
                // navigation is being used (see the logical page navigation #region below.)
                if (!this.UsingLogicalPageNavigation() && this.itemsViewSource.View != null)
                {
                    this.itemsViewSource.View.MoveCurrentToFirst();
                }
            }
            else
            {
                // Restore the previously saved state associated with this page
                if (e.PageState.ContainsKey("SelectedItem") && this.itemsViewSource.View != null)
                {
                    // TODO: Invoke Me.itemsViewSource.View.MoveCurrentTo() with the selected
                    //       item as specified by the value of pageState("SelectedItem")

                }
            }
        }

       

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="Common.SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="Common.NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
            if (this.itemsViewSource.View != null)
            {
                // TODO: Derive a serializable navigation parameter and assign it to
                //       pageState("SelectedItem")

            }
        }

        #region Logical page navigation

        // The split page is designed so that when the Window does have enough space to show
        // both the list and the details, only one pane will be shown at at time.
        //
        // This is all implemented with a single physical page that can represent two logical
        // pages.  The code below achieves this goal without making the user aware of the
        // distinction.

        private const int MinimumWidthForSupportingTwoPanes = 768;

        /// <summary>
        /// Invoked to determine whether the page should act as one logical page or two.
        /// </summary>
        /// <returns>True if the window should show act as one logical page, false
        /// otherwise.</returns>
        private bool UsingLogicalPageNavigation()
        {
            return Window.Current.Bounds.Width < MinimumWidthForSupportingTwoPanes;
        }

        /// <summary>
        /// Invoked with the Window changes size
        /// </summary>
        /// <param name="sender">The current Window</param>
        /// <param name="e">Event data that describes the new size of the Window</param>
        private void Window_SizeChanged(object sender, Windows.UI.Core.WindowSizeChangedEventArgs e)
        {
            this.InvalidateVisualState();
        }

        /// <summary>
        /// Invoked when an item within the list is selected.
        /// </summary>
        /// <param name="sender">The GridView displaying the selected item.</param>
        /// <param name="e">Event data that describes how the selection was changed.</param>
        private void ItemListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Invalidate the view state when logical page navigation is in effect, as a change
            // in selection may cause a corresponding change in the current logical page.  When
            // an item is selected this has the effect of changing from displaying the item list
            // to showing the selected item's details.  When the selection is cleared this has the
            // opposite effect.
            if (this.UsingLogicalPageNavigation()) this.InvalidateVisualState();
        }

        private bool CanGoBack()
        {
            if (this.UsingLogicalPageNavigation() && this.itemListView.SelectedItem != null)
            {
                return true;
            }
            else
            {
                return this.navigationHelper.CanGoBack();
            }
        }
        private void GoBack()
        {
            if (this.UsingLogicalPageNavigation() && this.itemListView.SelectedItem != null)
            {
                // When logical page navigation is in effect and there's a selected item that
                // item's details are currently displayed.  Clearing the selection will return to
                // the item list.  From the user's point of view this is a logical backward
                // navigation.
                this.itemListView.SelectedItem = null;
            }
            else
            {
                this.navigationHelper.GoBack();
            }
        }

        private void InvalidateVisualState()
        {
            var visualState = DetermineVisualState();
            VisualStateManager.GoToState(this, visualState, false);
            this.navigationHelper.GoBackCommand.RaiseCanExecuteChanged();
        }

        /// <summary>
        /// Invoked to determine the name of the visual state that corresponds to an application
        /// view state.
        /// </summary>
        /// <returns>The name of the desired visual state.  This is the same as the name of the
        /// view state except when there is a selected item in portrait and snapped views where
        /// this additional logical page is represented by adding a suffix of _Detail.</returns>
        private string DetermineVisualState()
        {
            if (!UsingLogicalPageNavigation())
                return "PrimaryView";

            // Update the back button's enabled state when the view state changes
            var logicalPageBack = this.UsingLogicalPageNavigation() && this.itemListView.SelectedItem != null;

            return logicalPageBack ? "SinglePane_Detail" : "SinglePane";
        }

        #endregion

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="Common.NavigationHelper.LoadState"/>
        /// and <see cref="Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Fisico plano = controller.getUser().getPlanoTreino();
            textBoxex11.Text = plano.pDia1()[0].getExercicio();
            textBoxzm11.Text = plano.pDia1()[0].getZonaMuscular();
            textBoxs11.Text = plano.pDia1()[0].getSeRep();
            textBoxex22.Text = plano.pDia1()[1].getExercicio();
            textBoxzm22.Text = plano.pDia1()[1].getZonaMuscular();
            textBoxs22.Text = plano.pDia1()[1].getSeRep();
            textBoxex33.Text = plano.pDia1()[2].getExercicio();
            textBoxzm33.Text = plano.pDia1()[2].getZonaMuscular();
            textBoxs33.Text = plano.pDia1()[2].getSeRep();
            textBoxex44.Text = plano.pDia1()[3].getExercicio();
            textBoxzm44.Text = plano.pDia1()[3].getZonaMuscular();
            textBoxs44.Text = plano.pDia1()[3].getSeRep();
            textBoxex55.Text = plano.pDia1()[4].getExercicio();
            textBoxzm55.Text = plano.pDia1()[4].getZonaMuscular();
            textBoxs55.Text = plano.pDia1()[4].getSeRep();
            textBoxex66.Text = plano.pDia1()[5].getExercicio();
            textBoxzm66.Text = plano.pDia1()[5].getZonaMuscular();
            textBoxs66.Text = plano.pDia1()[5].getSeRep();

        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
           
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
           
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            
        }

        

        private void txt_Objetivo_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            Fisico plano = controller.getUser().getPlanoTreino();
            textBoxex11.Text = plano.pDia2()[0].getExercicio();
            textBoxzm11.Text = plano.pDia2()[0].getZonaMuscular();
            textBoxs11.Text = plano.pDia2()[0].getSeRep();
            textBoxex22.Text = plano.pDia2()[1].getExercicio();
            textBoxzm22.Text = plano.pDia2()[1].getZonaMuscular();
            textBoxs22.Text = plano.pDia2()[1].getSeRep();
            textBoxex33.Text = plano.pDia2()[2].getExercicio();
            textBoxzm33.Text = plano.pDia2()[2].getZonaMuscular();
            textBoxs33.Text = plano.pDia2()[2].getSeRep();
            textBoxex44.Text = plano.pDia2()[3].getExercicio();
            textBoxzm44.Text = plano.pDia2()[3].getZonaMuscular();
            textBoxs44.Text = plano.pDia2()[3].getSeRep();
            textBoxex55.Text = plano.pDia2()[4].getExercicio();
            textBoxzm55.Text = plano.pDia2()[4].getZonaMuscular();
            textBoxs55.Text = plano.pDia2()[4].getSeRep();
            textBoxex66.Text = plano.pDia2()[5].getExercicio();
            textBoxzm66.Text = plano.pDia2()[5].getZonaMuscular();
            textBoxs66.Text = plano.pDia2()[5].getSeRep();
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            Fisico plano = controller.getUser().getPlanoTreino();
            textBoxex11.Text = plano.pDia3()[0].getExercicio();
            textBoxzm11.Text = plano.pDia3()[0].getZonaMuscular();
            textBoxs11.Text = plano.pDia3()[0].getSeRep();
            textBoxex22.Text = plano.pDia3()[1].getExercicio();
            textBoxzm22.Text = plano.pDia3()[1].getZonaMuscular();
            textBoxs22.Text = plano.pDia3()[1].getSeRep();
            textBoxex33.Text = plano.pDia3()[2].getExercicio();
            textBoxzm33.Text = plano.pDia3()[2].getZonaMuscular();
            textBoxs33.Text = plano.pDia3()[2].getSeRep();
            textBoxex44.Text = plano.pDia3()[3].getExercicio();
            textBoxzm44.Text = plano.pDia3()[3].getZonaMuscular();
            textBoxs44.Text = plano.pDia3()[3].getSeRep();
            textBoxex55.Text = plano.pDia3()[4].getExercicio();
            textBoxzm55.Text = plano.pDia3()[4].getZonaMuscular();
            textBoxs55.Text = plano.pDia3()[4].getSeRep();
            textBoxex66.Text = plano.pDia3()[5].getExercicio();
            textBoxzm66.Text = plano.pDia3()[5].getZonaMuscular();
            textBoxs66.Text = plano.pDia3()[5].getSeRep();
        }

        private void button4_Click_1(object sender, RoutedEventArgs e)
        {
            Fisico plano = controller.getUser().getPlanoTreino();
            textBoxex11.Text = plano.pDia4()[0].getExercicio();
            textBoxzm11.Text = plano.pDia4()[0].getZonaMuscular();
            textBoxs11.Text = plano.pDia4()[0].getSeRep();
            textBoxex22.Text = plano.pDia4()[1].getExercicio();
            textBoxzm22.Text = plano.pDia4()[1].getZonaMuscular();
            textBoxs22.Text = plano.pDia4()[1].getSeRep();
            textBoxex33.Text = plano.pDia4()[2].getExercicio();
            textBoxzm33.Text = plano.pDia4()[2].getZonaMuscular();
            textBoxs33.Text = plano.pDia4()[2].getSeRep();
            textBoxex44.Text = plano.pDia4()[3].getExercicio();
            textBoxzm44.Text = plano.pDia4()[3].getZonaMuscular();
            textBoxs44.Text = plano.pDia4()[3].getSeRep();
            textBoxex55.Text = plano.pDia4()[4].getExercicio();
            textBoxzm55.Text = plano.pDia4()[4].getZonaMuscular();
            textBoxs55.Text = plano.pDia4()[4].getSeRep();
            textBoxex66.Text = plano.pDia4()[5].getExercicio();
            textBoxzm66.Text = plano.pDia4()[5].getZonaMuscular();
            textBoxs66.Text = plano.pDia4()[5].getSeRep();
        }

        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            Fisico plano = controller.getUser().getPlanoTreino();
            textBoxex11.Text = plano.pDia5()[0].getExercicio();
            textBoxzm11.Text = plano.pDia5()[0].getZonaMuscular();
            textBoxs11.Text = plano.pDia5()[0].getSeRep();
            textBoxex22.Text = plano.pDia5()[1].getExercicio();
            textBoxzm22.Text = plano.pDia5()[1].getZonaMuscular();
            textBoxs22.Text = plano.pDia5()[1].getSeRep();
            textBoxex33.Text = plano.pDia5()[2].getExercicio();
            textBoxzm33.Text = plano.pDia5()[2].getZonaMuscular();
            textBoxs33.Text = plano.pDia5()[2].getSeRep();
            textBoxex44.Text = plano.pDia5()[3].getExercicio();
            textBoxzm44.Text = plano.pDia5()[3].getZonaMuscular();
            textBoxs44.Text = plano.pDia5()[3].getSeRep();
            textBoxex55.Text = plano.pDia5()[4].getExercicio();
            textBoxzm55.Text = plano.pDia5()[4].getZonaMuscular();
            textBoxs55.Text = plano.pDia5()[4].getSeRep();
            textBoxex66.Text = plano.pDia5()[5].getExercicio();
            textBoxzm66.Text = plano.pDia5()[5].getZonaMuscular();
            textBoxs66.Text = plano.pDia5()[5].getSeRep();
        }

        private void button6_Click_1(object sender, RoutedEventArgs e)
        {
            Fisico plano = controller.getUser().getPlanoTreino();
            textBoxex11.Text = plano.pDia6()[0].getExercicio();
            textBoxzm11.Text = plano.pDia6()[0].getZonaMuscular();
            textBoxs11.Text = plano.pDia6()[0].getSeRep();
            textBoxex22.Text = plano.pDia6()[1].getExercicio();
            textBoxzm22.Text = plano.pDia6()[1].getZonaMuscular();
            textBoxs22.Text = plano.pDia6()[1].getSeRep();
            textBoxex33.Text = plano.pDia6()[2].getExercicio();
            textBoxzm33.Text = plano.pDia6()[2].getZonaMuscular();
            textBoxs33.Text = plano.pDia6()[2].getSeRep();
            textBoxex44.Text = plano.pDia6()[3].getExercicio();
            textBoxzm44.Text = plano.pDia6()[3].getZonaMuscular();
            textBoxs44.Text = plano.pDia6()[3].getSeRep();
            textBoxex55.Text = plano.pDia6()[4].getExercicio();
            textBoxzm55.Text = plano.pDia6()[4].getZonaMuscular();
            textBoxs55.Text = plano.pDia6()[4].getSeRep();
            textBoxex66.Text = plano.pDia6()[5].getExercicio();
            textBoxzm66.Text = plano.pDia6()[5].getZonaMuscular();
            textBoxs66.Text = plano.pDia6()[5].getSeRep();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Login), controller.getApp());
        }
    }
}
