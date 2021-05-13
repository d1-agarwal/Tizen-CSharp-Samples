/*
* Copyright (c) 2017 Samsung Electronics Co., Ltd All Rights Reserved
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using Sensor.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Sensor
{
    /// <summary>
    /// Application class
    /// </summary>
    public class SensorApp : Application
    {
        /// <summary>
        /// Initializes a new instance of the app class
        /// </summary>
        public SensorApp()
        {
            // The root page of your application
            MainPage = new NavigationPage(new SensorMain());
        }

        /// <summary>
        /// Handles when your app starts
        /// </summary>
        protected override void OnStart()
        {
        }

        /// <summary>
        /// Handles when your app sleeps
        /// </summary>
        protected override void OnSleep()
        {
        }

        /// <summary>
        /// Handles when your app resumes
        /// </summary>
        protected override void OnResume()
        {
        }
    }
}
