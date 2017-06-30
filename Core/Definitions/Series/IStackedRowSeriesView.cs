﻿//The MIT License(MIT)

//Copyright(c) 2016 Alberto Rodriguez & ZmCharts Contributors

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

namespace ZmCharts.Definitions.Series
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ZmCharts.Definitions.Series.ISeriesView" />
    /// <seealso cref="ZmCharts.Definitions.Series.IStackModelableSeriesView" />
    public interface IStackedRowSeriesView : ISeriesView, IStackModelableSeriesView
    {
        /// <summary>
        /// Gets or sets the maximum height of the row.
        /// </summary>
        /// <value>
        /// The maximum height of the row.
        /// </value>
        double MaxRowHeight { get; set; }
        /// <summary>
        /// Gets or sets the row padding.
        /// </summary>
        /// <value>
        /// The row padding.
        /// </value>
        double RowPadding { get; set; }
    }
}