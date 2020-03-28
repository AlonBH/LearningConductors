using Caliburn.Micro;

namespace LearningConductors.ViewModels
{
    public class ShellViewModel : Conductor<Screen>.Collection.AllActive
    {
        public RedViewModel Red { get; set; }
        public GreenViewModel Green{ get; set; }
        public BlueViewModel Blue { get; set; }
        public ShellViewModel()
        {
            Red = new RedViewModel();
            Green = new GreenViewModel();
            Blue = new BlueViewModel();
        }

        private void ToggleActivation(Screen screen)
        {
            if (screen.IsActive)
            {
                DeactivateItem(screen, true);
            }
            else
            {
                ActivateItem(screen);
            }
        }

        public void ToggleRed()
        {
            ToggleActivation(Red);
        }

        public void ToggleBlue()
        {
            ToggleActivation(Blue);
        }

        public void ToggleGreen()
        {
            ToggleActivation(Green);
        }
    }
}