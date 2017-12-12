using TeknikServis.BLL.Repository.Entity;

namespace TeknikServis.BLL.Service
{
    public class EntityService
    {
        public EntityService()
        {
           
            arizaRepository = new ArizaRepository();
            detayRepository = new DetayRepository();
            kategoriRepository = new KategoriRepository();
            markaRepository = new MarkaRepository();
            modelRepository = new ModelRepository();
            musteriRepository = new MusteriRepository();
            personelRepository = new PersonelRepository();
            servisDurumRepository = new ServisDurumRepository();
            servisYeriRepository = new ServisYeriRepository();
            urunRepository = new UrunRepository();
            urunTeslimRepository = new UrunTeslimRepository();

        }
    
        private ArizaRepository arizaRepository;

        public ArizaRepository ArizaService
        {
            get { return arizaRepository; }
            set { arizaRepository = value; }
        }
        private DetayRepository detayRepository;

        public DetayRepository DetayService
        {
            get { return detayRepository; }
            set { detayRepository = value; }
        }
        private KategoriRepository kategoriRepository;

        public KategoriRepository KategoriService
        {
            get { return kategoriRepository; }
            set { kategoriRepository = value; }
        }

        private MarkaRepository markaRepository;

        public MarkaRepository MarkaService
        {
            get { return markaRepository; }
            set { markaRepository = value; }
        }
        private ModelRepository modelRepository;

        public ModelRepository ModelService
        {
            get { return modelRepository; }
            set { modelRepository = value; }
        }
        private MusteriRepository musteriRepository;

        public MusteriRepository MusteriService
        {
            get { return musteriRepository; }
            set { musteriRepository = value; }
        }
        private PersonelRepository personelRepository;

        public PersonelRepository PersonelService
        {
            get { return personelRepository; }
            set { personelRepository = value; }
        }
        private ServisDurumRepository servisDurumRepository;

        public ServisDurumRepository ServisDurumService
        {
            get { return servisDurumRepository; }
            set { servisDurumRepository = value; }
        }
        private ServisYeriRepository servisYeriRepository;

        public ServisYeriRepository ServisYeriService
        {
            get { return servisYeriRepository; }
            set { servisYeriRepository = value; }
        }
        private UrunRepository urunRepository;

        public UrunRepository UrunService
        {
            get { return urunRepository; }
            set { urunRepository = value; }
        }
        private UrunTeslimRepository urunTeslimRepository;

        public UrunTeslimRepository UrunTeslimService
        {
            get { return urunTeslimRepository; }
            set { urunTeslimRepository = value; }
        }



    }
}
