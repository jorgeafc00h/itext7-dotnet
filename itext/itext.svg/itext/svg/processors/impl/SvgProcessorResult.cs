/*
This file is part of the iText (R) project.
Copyright (c) 1998-2021 iText Group NV
Authors: iText Software.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License version 3
as published by the Free Software Foundation with the addition of the
following permission added to Section 15 as permitted in Section 7(a):
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
OF THIRD PARTY RIGHTS

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program; if not, see http://www.gnu.org/licenses or write to
the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
Boston, MA, 02110-1301 USA, or download the license from the following URL:
http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions
of this program must display Appropriate Legal Notices, as required under
Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License,
a covered work must retain the producer line in every PDF that is created
or manipulated using iText.

You can be released from the requirements of the license by purchasing
a commercial license. Buying such a license is mandatory as soon as you
develop commercial activities involving the iText software without
disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP,
serving PDFs on the fly in a web application, shipping iText with a closed
source product.

For more information, please contact iText Software Corp. at this
address: sales@itextpdf.com
*/
using System;
using System.Collections.Generic;
using iText.Layout.Font;
using iText.Svg.Processors;
using iText.Svg.Renderers;

namespace iText.Svg.Processors.Impl {
    /// <summary>
    /// A wrapper class that encapsulates processing results of
    /// <see cref="iText.Svg.Processors.ISvgProcessor"/>
    /// objects.
    /// </summary>
    public class SvgProcessorResult : ISvgProcessorResult {
        private readonly IDictionary<String, ISvgNodeRenderer> namedObjects;

        private readonly ISvgNodeRenderer root;

        [System.ObsoleteAttribute(@"Will be removed in 7.2.")]
        private readonly FontProvider fontProvider;

        [System.ObsoleteAttribute(@"Will be removed in 7.2.")]
        private readonly FontSet tempFonts;

        private readonly SvgProcessorContext context;

        /// <summary>
        /// Creates new
        /// <see cref="SvgProcessorResult"/>
        /// entity.
        /// </summary>
        /// <param name="namedObjects">
        /// a map of named-objects with their id's as
        /// <see cref="System.String"/>
        /// keys and
        /// the
        /// <see cref="iText.Svg.Renderers.ISvgNodeRenderer"/>
        /// objects as values.
        /// </param>
        /// <param name="root">
        /// a wrapped
        /// <see cref="iText.Svg.Renderers.ISvgNodeRenderer"/>
        /// root renderer.
        /// </param>
        /// <param name="fontProvider">
        /// a
        /// <see cref="iText.Layout.Font.FontProvider"/>
        /// instance.
        /// </param>
        /// <param name="tempFonts">
        /// a
        /// <see cref="iText.Layout.Font.FontSet"/>
        /// containing temporary fonts.
        /// </param>
        [System.ObsoleteAttribute(@"use SvgProcessorResult(System.Collections.Generic.IDictionary{K, V}, iText.Svg.Renderers.ISvgNodeRenderer, SvgProcessorContext) instead. Will be removed in 7.2."
            )]
        public SvgProcessorResult(IDictionary<String, ISvgNodeRenderer> namedObjects, ISvgNodeRenderer root, FontProvider
             fontProvider, FontSet tempFonts) {
            this.namedObjects = namedObjects;
            this.root = root;
            this.fontProvider = fontProvider;
            this.tempFonts = tempFonts;
            this.context = new SvgProcessorContext(new SvgConverterProperties());
        }

        /// <summary>
        /// Creates new
        /// <see cref="SvgProcessorResult"/>
        /// entity.
        /// </summary>
        /// <param name="namedObjects">
        /// a map of named-objects with their id's as
        /// <see cref="System.String"/>
        /// keys and
        /// the
        /// <see cref="iText.Svg.Renderers.ISvgNodeRenderer"/>
        /// objects as values.
        /// </param>
        /// <param name="root">
        /// a wrapped
        /// <see cref="iText.Svg.Renderers.ISvgNodeRenderer"/>
        /// root renderer.
        /// </param>
        /// <param name="context">
        /// a
        /// <see cref="SvgProcessorContext"/>
        /// instance.
        /// </param>
        public SvgProcessorResult(IDictionary<String, ISvgNodeRenderer> namedObjects, ISvgNodeRenderer root, SvgProcessorContext
             context) {
            this.namedObjects = namedObjects;
            this.root = root;
            this.context = context;
            this.fontProvider = context.GetFontProvider();
            this.tempFonts = context.GetTempFonts();
        }

        public virtual IDictionary<String, ISvgNodeRenderer> GetNamedObjects() {
            return namedObjects;
        }

        public virtual ISvgNodeRenderer GetRootRenderer() {
            return root;
        }

        public virtual FontProvider GetFontProvider() {
            return fontProvider;
        }

        public virtual FontSet GetTempFonts() {
            return tempFonts;
        }

        /// <summary>
        /// Gets processor context, containing
        /// <see cref="iText.Layout.Font.FontProvider"/>
        /// and
        /// <see cref="iText.Layout.Font.FontSet"/>
        /// of temporary fonts inside.
        /// </summary>
        /// <returns>
        /// 
        /// <see cref="SvgProcessorContext"/>
        /// instance
        /// </returns>
        public virtual SvgProcessorContext GetContext() {
            return context;
        }

        public override bool Equals(Object o) {
            if (o == null || (!o.GetType().Equals(this.GetType()))) {
                return false;
            }
            iText.Svg.Processors.Impl.SvgProcessorResult otherResult = (iText.Svg.Processors.Impl.SvgProcessorResult)o;
            return otherResult.GetNamedObjects().Equals(this.GetNamedObjects()) && otherResult.GetRootRenderer().Equals
                (this.GetRootRenderer());
        }

        public override int GetHashCode() {
            return GetNamedObjects().GetHashCode() + 43 * GetRootRenderer().GetHashCode();
        }
    }
}
