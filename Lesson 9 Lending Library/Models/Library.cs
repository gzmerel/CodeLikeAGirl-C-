namespace LendingLibrary.Models
{
    public  class Library 
    {
        public List<Novel> Novels { get; set; } = new List<Novel>();
        public List<TextBook> TextBooks { get; set; } = new List<TextBook>(); 
        public List<Album> Albums { get; set; }= new List<Album>(); 
        public List<AudioBook> AudioBooks  { get; set; }= new List<AudioBook>(); 

    public void AddNovel(Novel novel)
    {
        Novels.Add(novel);
    }
    public void AddTextBook(TextBook textBook)
    {
        TextBooks.Add(textBook);
    }
    public void AddAlbum(Album album)
    {
        Albums.Add(album);
    }
    public void AddAudioBook(AudioBook audioBook)
    {
        AudioBooks.Add(audioBook);
    }
    
    }
}