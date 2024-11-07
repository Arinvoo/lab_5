namespace lab_5
{
    public class BakeryBuilder
    {
        private string _name;
        private string _flourType;
        private bool _hasSeeds;
        private bool _isGlutenFree;

        public BakeryBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public BakeryBuilder SetFlourType(string flourType)
        {
            _flourType = flourType;
            return this;
        }

        public BakeryBuilder AddSeeds(bool hasSeeds)
        {
            _hasSeeds = hasSeeds;
            return this;
        }

        public BakeryBuilder SetGlutenFree(bool isGlutenFree)
        {
            _isGlutenFree = isGlutenFree;
            return this;
        }

        public Bread Build()
        {
            return new Bread(_name, _flourType, _hasSeeds, _isGlutenFree);
        }
    }
}
