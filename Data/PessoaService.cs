namespace Desafio.Data
{
    public class PessoaService
    {

        private readonly AppDBContext db;

        public PessoaService(AppDBContext db)
        {
            this.db = db;
        }

        public List<Pessoa> GetAll()
        {
            return db.Pessoas.ToList();
        }

        public Pessoa GetById(int id)
        {
            return db.Pessoas.FirstOrDefault(pessoa => pessoa.Id == id);
        }

        public void Create(Pessoa pessoa)
        {
            pessoa.DataCadastro = DateTime.Now;

            db.Add(pessoa);
            db.SaveChangesAsync();
        }

        public void Save(Pessoa pessoa)
        {
            db.Update(pessoa);
            db.SaveChangesAsync();
        }

        public void Delete(Pessoa pessoa)
        {
            db.Remove(pessoa);
            db.SaveChangesAsync();
        }
    }
}