using ReactiveUI;
using System.Linq;
using Xamarin.Forms;
namespace CFEApp
{
    public class MainOfflineViewModel: ReactiveObject
    {
        ReactiveList<Herramientas> _todos;
        public ReactiveList<Herramientas> Todos
        {
            get => _todos;
            set => this.RaiseAndSetIfChanged(ref _todos, value);
        }
        private Herramientas _selectedTodo;
        public Herramientas SelectedTodo
        {
            get => _selectedTodo;
            set => this.RaiseAndSetIfChanged(ref _selectedTodo, value);
        }

        ServiceHerramientaDB _herramientasS;

        public MainOfflineViewModel()
        {
            _herramientasS = new ServiceHerramientaDB();
            var todos = _herramientasS.ReadAllItems();

            var sg = todos.Count();
            Application.Current.MainPage.DisplayAlert("dsa",sg.ToString(),"da");
            if (todos.Any())
            {
                Todos = new ReactiveList<Herramientas>(todos) { ChangeTrackingEnabled = true };
            }
            else { Todos = new ReactiveList<Herramientas>() { ChangeTrackingEnabled = true }; }
        }
    }
}
