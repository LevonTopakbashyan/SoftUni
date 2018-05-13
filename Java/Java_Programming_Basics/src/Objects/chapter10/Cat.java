package Objects.chapter10;

public class Cat {

    private String name;
    private String furColor;

    public String getName() {
        return name;
    }

    public String getFurColor() {
        return furColor;
    }

    public Cat(String name, String furColor) {
        this.name = name;
        this.furColor = furColor;
    }

    public void sayMeow(){
        System.out.printf("%s with %s color of fur saying meow!\n",getName(),getFurColor());
    }
}
