// У завданні 1 було порушено принцип єдиності відповідальності
// Клас Order мав багато методів і відповідальності за різні аспекти
// замовлення

// Аби виправити це я розділив клас Order на окремі класи

// OrderItemManager для роботи зі списком товарів
// OrderDataManager для роботи з даними замовлення 

// Думаю я зробив код більш читабельним і відповіднім до принципу
// єдиності відповідальності (Singe Responsibility Priciple)

class Item
{
}

class OrderItemManager
{
    private List<Item>? itemList;

    public void AddItem(Item item) {/*...*/}
    public void DeleteItem(Item item) {/*...*/}
    public List<Item> GetItems() { return itemList; }
    public int GetItemCount() { return itemList.Count; }
    public void CalculateTotalSum() {/*...*/}
}

class OrderDataManager
{
    public void Load() {/*...*/}
    public void Save() {/*...*/}
    public void Update() {/*...*/}
    public void Delete() {/*...*/}
}

class Order
{
    private OrderItemManager itemManager;
    private OrderDataManager dataManager;

    public Order()
    {
        itemManager = new OrderItemManager();
        dataManager = new OrderDataManager();
    }

    public void PrintOrder() {/*...*/}
    public void ShowOrder() {/*...*/}
}
