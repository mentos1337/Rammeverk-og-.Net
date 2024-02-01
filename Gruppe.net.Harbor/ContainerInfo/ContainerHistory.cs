namespace Gruppe.net.Harbor.ContainerInfo
{
    public class ContainerHistory
    {
        private List<Location> locations {  get; set; } 
        public int getContainerHistory(int containerId) { return locations.Count; } 
    }
}
