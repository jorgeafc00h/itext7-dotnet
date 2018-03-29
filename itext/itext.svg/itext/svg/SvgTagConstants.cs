/*
This file is part of the iText (R) project.
Copyright (c) 1998-2017 iText Group NV
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
using iText.IO.Util;

namespace iText.Svg {
    /// <summary>Class containing constants to represent all the SVG-tags.</summary>
    public sealed class SvgTagConstants {
        public const String CSS_STROKE_WIDTH_PROPERTY = "stroke-width";

        private SvgTagConstants() {
        }

        public const String CIRCLE = "circle";

        public const String DEFS = "defs";

        public const String ELLIPSE = "ellipse";

        public const String FOREIGN_OBJECT = "foreignObject";

        public const String G = "g";

        public const String IMAGE = "image";

        public const String LINE = "line";

        public const String LINEAR_GRADIENT = "linearGradient";

        public const String PATH = "path";

        public const String PATTERN = "pattern";

        public const String POLYLINE = "polyline";

        public const String POLYGON = "polygon";

        public const String RADIAL_GRADIENT = "radialGradient";

        public const String RECT = "rect";

        public const String SVG = "svg";

        public const String SYMBOL = "symbol";

        public const String TEXT = "text";

        public const String TSPAN = "tspan";

        public const String TEXTPATH = "textpath";

        public const String USE = "use";

        public const String X = "x";

        public const String X1 = "x1";

        public const String X2 = "x2";

        public const String SY = "y";

        public const String Y1 = "y1";

        public const String Y2 = "y2";

        public const String TRANSFORM = "transform";

        public const String ANIMATE = "animate";

        public const String ANIMATE_MOTION = "animateMotion";

        public const String ANIMATE_TRANSFORM = "animateTransform";

        public const String DISCARD = "discard";

        public const String SET = "set";

        public static readonly ICollection<String> ANIMATION_ELEMENTS = JavaCollectionsUtil.UnmodifiableSet(new HashSet
            <String>(JavaUtil.ArraysAsList(ANIMATE, ANIMATE_MOTION, ANIMATE_TRANSFORM, DISCARD, SET)));

        public const String STYLE = "style";
        // tags
        // attributes
        //Animation
        //CSS
    }
}
