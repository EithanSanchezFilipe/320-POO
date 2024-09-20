namespace Drones
{
    public partial class Building
    {
        private SolidBrush buildingBrush = new SolidBrush(Color.Purple);
        // De manière graphique
        public void Render(BufferedGraphics drawingSpace, Building building)
        {
            if(building.GetType() == typeof(Store))
                drawingSpace.Graphics.FillEllipse(buildingBrush, X, Y, Width, Height);
            else if(building.GetType() == typeof(Factory))
                drawingSpace.Graphics.FillRectangle(buildingBrush, X, Y, Width, Height);
        }
    }
}
