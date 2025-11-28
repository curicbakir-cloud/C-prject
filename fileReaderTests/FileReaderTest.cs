using FileReaderApp;



namespace fileReaderAppTests
{
    public class fileReaderTests
    {
        [Fact]
        public void ReadEmptyFile()
        {
            Assert.Throws<ArgumentException>(() => FileReader.ReadFile(""));
        }
    }
}