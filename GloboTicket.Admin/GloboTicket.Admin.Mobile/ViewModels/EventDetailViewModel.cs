namespace GloboTicket.Admin.Mobile.ViewModels
{
    public class EventDetailViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public EventStatusEnum EventStatus { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public List<string> Artists { get; set; } = new();
        public CategoryViewModel Category { get; set; }

        public EventDetailViewModel()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
            Price = 0.0;
            ImageUrl = string.Empty;
            EventStatus = EventStatusEnum.OnSale;
            Date = DateTime.Now;
            Artists = new();
            Category = new CategoryViewModel();
        }
    }
}
