namespace Concert.Services 
{
    public interface IUserService
    {
        Task<string> GetAvatarUrlAsync(string userName);
    }
}