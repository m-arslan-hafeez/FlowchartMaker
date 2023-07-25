using System.Collections.Generic;
using System.Drawing;

namespace FlowchartMaker
{
    class FlowchartElement
    {
        public string NodeText { get; set; }

        //public string Text { get; set; }

        public Point Position { get; set; }

        public List<FlowchartElement> Connections { get; set; }

        public FlowchartElement()
        {
            Connections = new List<FlowchartElement>();
        }
    }
}
