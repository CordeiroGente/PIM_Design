using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ModernDesign.MVVM.ViewModel
{
    internal class EmAbertoViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Order> Orders { get; } = new ObservableCollection<Order>();

        public EmAbertoViewModel()
        {       
            // Exemplo de dados; substitua pelo seu carregamento real
            Orders.Add(new Order { OrderNumber = "PED-001", Customer = "Cliente A", Date = DateTime.Today.AddDays(-3), Status = "Pendente" });
            Orders.Add(new Order { OrderNumber = "PED-002", Customer = "Cliente B", Date = DateTime.Today.AddDays(-2), Status = "Aguardando Pagto" });
            Orders.Add(new Order { OrderNumber = "PED-003", Customer = "Cliente C com nome longo para teste de corte", Date = DateTime.Today.AddDays(-1), Status = "Pendente" });
            Orders.Add(new Order { OrderNumber = "PED-004", Customer = "Cliente D", Date = DateTime.Today, Status = "Confirmado" });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    internal class Order
    {
        public string OrderNumber { get; set; }
        public string Customer { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }
}
