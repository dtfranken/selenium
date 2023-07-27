// <copyright file="ChromiumDriverLogLevel.cs" company="WebDriver Committers">
// Licensed to the Software Freedom Conservancy (SFC) under one
// or more contributor license agreements. See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership. The SFC licenses this file
// to you under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

namespace OpenQA.Selenium.Chromium
{
    /// <summary>
    /// Represents the <see href="https://source.chromium.org/chromium/chromium/src/+/master:chrome/test/chromedriver/logging.cc">log levels</see> defined by ChromeDriver.
    /// </summary>
    public enum ChromiumDriverLogLevel
    {
        /// <summary>
        /// Represents the ALL log level.
        /// </summary>
        All,

        /// <summary>
        /// Represents the DEBUG log level.
        /// </summary>
        Debug,

        /// <summary>
        /// Represents the INFO log level.
        /// </summary>
        Info,

        /// <summary>
        /// Represents the WARNING log level.
        /// </summary>
        Warning,

        /// <summary>
        /// Represents the SEVERE log level.
        /// </summary>
        Severe,

        /// <summary>
        /// Represents the OFF log level.
        /// </summary>
        Off
    }
}
