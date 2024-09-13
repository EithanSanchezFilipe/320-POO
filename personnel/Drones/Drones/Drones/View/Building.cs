namespace Drones
{
    public partial class Building
    {
        private SolidBrush buildingBrush = new SolidBrush(Color.Purple);

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillRectangle(buildingBrush, X, Y, Width, Height);
        }
    }
}
