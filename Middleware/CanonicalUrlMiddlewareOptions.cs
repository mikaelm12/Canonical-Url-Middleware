// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.


namespace Middleware.CanonicalURL
{
    /// <summary>
    /// Options for CanonicalUrlConfigurations
    /// </summary>
    public class CanonicalURLMiddlewareOptions
    {
        public bool _enforceLowercaseUrls;
        public bool _caseSensitiveQueryString; 
        public bool _removeTrailingSlash;
        
        
        public CanonicalURLMiddlewareOptions(){}

        public void EnforceLowercaseUrls(){
            _enforceLowercaseUrls = true;
        }

        public void RemoveTrailingSlash(){
            _removeTrailingSlash = true;
        }

        public void MakeQueryStringCaseSensitive(){
            _caseSensitiveQueryString = true;
        }

        public bool MakeUrlsLowerCase(){
            return _enforceLowercaseUrls;
        }
        public bool IsQueryStringCaseSensitive()
        {
            return _caseSensitiveQueryString;
        }

        public bool ShouldRemoveTrailingSlash()
        {
            return _removeTrailingSlash;
        }
    }
}