namespace SerieAPI.Clases;

interface ISerie{
    void Add(SerieDTO serie);
    void Delete(int id);
    void Update(int id, SerieDTO serie);
    List<SerieDTO> All();

}
