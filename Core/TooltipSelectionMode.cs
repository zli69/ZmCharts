//The MIT License(MIT)

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

namespace ZmCharts
{
    /// <summary>
    /// Tooltip selection modes
    /// </summary>
    public enum TooltipSelectionMode
    {
        /// <summary>
        /// ZmCharts will decide the selection mode based on the series (that fired the tooltip) preferred section mode
        /// </summary>
        Auto,
        /// <summary>
        /// Gets only the hovered point 
        /// </summary>
        OnlySender,
        /// <summary>
        /// Gets all the points that shares the value X in the chart
        /// </summary>
        SharedXValues,
        /// <summary>
        /// Gets all the points that shares the value Y in the chart
        /// </summary>
        SharedYValues,
        /// <summary>
        /// Gets all the points that shares the value X in the hovered series
        /// </summary>
        SharedXInSeries,
        /// <summary>
        /// Gets all the points that shares the value Y in the hovered series
        /// </summary>
        SharedYInSeries
    }
}