using DietFit.Common;
using DietFit.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace DietFit.Views
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Login : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public Login()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
            Utilizador admin = new Utilizador();
            admin.setPnome("Admin");
            admin.setPassword("1234");
            admin.setUsername("admin");
            admin.setIsAdmin(true);
            Appl.addUser(admin);
        }


        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }


        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void CriarConta(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CriarConta));
        }

        private void Entrar(object sender, RoutedEventArgs e)
        {
            Utilizador u = Appl.getUtilizadorByUser(this.txtcaixa_User.Text);
            if (u == null)
            {
                //pop up user nao existe
            }
            else
            {
                if (u.getPassword().Equals(this.txtcaixa_Pwdr.Password))
                {
                    if (u.getIsAdmin())
                    {
                        this.Frame.Navigate(typeof(Views.AdminPage));
                    }
                    else {
                        Appl.setLastLoggedUser(u);
                        this.Frame.Navigate(typeof(Views.Menu));
                        Ambiente ambiente = new Ambiente(u);
                    }
                }
                else
                {
                    var dialog = new Windows.UI.Popups.MessageDialog("Palavras passe errada");
                }
            }
            }

        private void CommandBar_Opened(object sender, object e)
        {

        }

        private void Ajuda(object sender, RoutedEventArgs e)
        {
          //  this.Frame.Navigate((typeof(Views.Ajuda)));

        }
    }
}
