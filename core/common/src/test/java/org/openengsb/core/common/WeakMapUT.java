/**
 * Copyright 2010 OpenEngSB Division, Vienna University of Technology
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package org.openengsb.core.common;

import static org.hamcrest.CoreMatchers.is;
import static org.hamcrest.CoreMatchers.nullValue;
import static org.hamcrest.CoreMatchers.sameInstance;
import static org.junit.Assert.assertThat;

import org.apache.commons.collections.map.AbstractReferenceMap;
import org.apache.commons.collections.map.ReferenceMap;
import org.junit.Test;

public class WeakMapUT {
    @Test
    public void testReferenceMap() throws Exception {
        ReferenceMap map = new ReferenceMap(AbstractReferenceMap.HARD,
            AbstractReferenceMap.WEAK);
        Object referent = new Object();
        map.put("42", referent);
        assertThat(map.containsKey("42"), is(true));
        assertThat(map.get("42"), sameInstance(referent));
        referent = null;
        System.gc();
        assertThat(map.containsKey("42"), is(false));
        assertThat(map.get("42"), nullValue());
    }
}