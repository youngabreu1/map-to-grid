namespace map_to_grid.Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Playlist\pgm\Mapas\13-10-2023.txt";
            ToGrid mapa = new ToGrid();
            mapa.GetData(path);

        }
    }

}
