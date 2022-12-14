﻿using TryitterWebAPI.Models;

namespace TryitterWebAPI.Repository
{
    public interface IPostRepository
    {
        Task<Post> GetPostById(int id);
        Task<string> CreatePost(Post post);
        string UpdatePost(Post post, int postId);
        void DeletePost(int id);
    }
}
