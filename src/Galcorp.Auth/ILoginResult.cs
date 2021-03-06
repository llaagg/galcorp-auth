﻿namespace Galcorp.Auth
{
    public interface ILoginResult
    {
        /// <summary>
        ///     Indicates if login attempt was succesfull
        /// </summary>
        bool Success { get; }

        string AccessToken { get; }

        string IdToken { get; }
    }
}