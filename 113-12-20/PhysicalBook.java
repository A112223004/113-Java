public class PhysicalBook extends Book{
    private String shelfLocation;

    public PhysicalBook(String title, String author, String location){
        super(title, author);
        this.shelfLocation = shelfLocation;
    }

    public String getShelfLocating(){
        return shelfLocation;
    }

    @Override
    public String toString(){
        return super.toString() + ", 書架位置: " + shelfLocation;
    }

}
