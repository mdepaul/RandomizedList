/* Attributions
 * Mike DePaul
 * https://github.com/mdepaul/RandomizedList.git
 * **/
namespace MD.RandomizedList
{
    public interface IPrng
    {
        byte GetRandomByte();

        byte[] GetRandomBytes(int numberOfBytes);

        void Reseed();
    }
}
