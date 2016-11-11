﻿using System.Threading.Tasks;
using InstagramAPI.Classes;

namespace InstagramAPI.API
{
    public interface IInstaApi
    {
        bool IsUserAuthenticated { get; }
        IResult<InstaUser> GetUser(string username);
        Task<IResult<InstaUser>> GetUserAsync(string username);
        IResult<InstaMediaList> GetUserMedia(string username, int maxPages = 0);
        Task<IResult<InstaMediaList>> GetUserMediaAsync(string username, int maxPages = 0);
        IResult<InstaMedia> GetMediaByCode(string postCode);
        Task<IResult<InstaMedia>> GetMediaByCodeAsync(string postCode);
        IResult<bool> Login();
        Task<IResult<bool>> LoginAsync();
        IResult<InstaFeed> GetUserFeed(int maxPages = 0);
        Task<IResult<InstaFeed>> GetUserFeedAsync(int maxPages = 0);
    }
}