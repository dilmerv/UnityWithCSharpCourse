namespace StringExtensionFeatures
{
    public class XRRig
    {
        private string spaceType;

        private float floorPosition;

        public string Space { get { return spaceType; }}
        
        public XRRig(string spaceType, float floorPosition)
        {
            this.spaceType = spaceType;
            this.floorPosition = floorPosition;
        }
    }
}