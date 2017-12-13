﻿#if WEBAPI
namespace Microsoft.Web.Http.Versioning.Conventions
#else
namespace Microsoft.AspNetCore.Mvc.Versioning.Conventions
#endif
{
    using System;

    /// <summary>
    /// Defines the behavior of an API version convention.
    /// </summary>
    public interface IApiVersionConvention<T>
    {
        /// <summary>
        /// Applies the API version convention.
        /// </summary>
        /// <param name="item">The descriptor to apply the convention to.</param>
        void ApplyTo( T item );
    }
}