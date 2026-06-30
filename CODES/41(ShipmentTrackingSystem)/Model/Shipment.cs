namespace ShipmentTrackingSystem.Models
{
    class Shipment
    {
        public int ShipmentID { get; set; }

        public string Source { get; set; }

        public string Destination { get; set; }

        public string Status { get; set; }

        public string DispatchDate { get; set; }

        public string DeliveryDate { get; set; }
    }
}
