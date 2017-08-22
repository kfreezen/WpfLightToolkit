﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WpfLightToolkit.Interfaces
{
    public interface IContentLoader
    {
        Task<object> LoadContentAsync(FrameworkElement parent, object page, CancellationToken cancellationToken);

        void SizeContentChanged(FrameworkElement parent, object page);
    }
}
