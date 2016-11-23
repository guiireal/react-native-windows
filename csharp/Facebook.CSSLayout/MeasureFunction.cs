﻿/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

namespace Facebook.CSSLayout
{
    public delegate long MeasureFunction(
        CSSNode node,
        float width,
        CSSMeasureMode widthMode,
        float height,
        CSSMeasureMode heightMode);
}