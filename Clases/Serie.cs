namespace SerieAPI.Clases;

public class Serie : ISerie
{
    private List<SerieDTO> DB;

    public Serie(){
        this.DB = new List<SerieDTO>();
    }
    public void Add(SerieDTO serie)
    {
        this.DB.Add(serie);
    }
    public void Delete(int id)
    {
        this.DB.RemoveAll(serie => serie.Id == id);
    }
    public List<SerieDTO>All()
    {
        return this.DB;
    }
    public void Update(int id, SerieDTO serie)
    {
        SerieDTO serieUpdate = this.DB.Single(serie => serie.Id == id);
        serieUpdate.Titulo = serie.Titulo;
        serieUpdate.Genero = serie.Genero;
        serie.Temporadas = serie.Temporadas;
        
    }
}