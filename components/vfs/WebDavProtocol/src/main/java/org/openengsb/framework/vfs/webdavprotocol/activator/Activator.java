/**
 * Licensed to the Austrian Association for Software Tool Integration (AASTI)
 * under one or more contributor license agreements. See the NOTICE file
 * distributed with this work for additional information regarding copyright
 * ownership. The AASTI licenses this file to you under the Apache License,
 * Version 2.0 (the "License"); you may not use this file except in compliance
 * with the License. You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package org.openengsb.framework.vfs.webdavprotocol.activator;

import org.openengsb.framework.vfs.webdavprotocol.webdavhandler.WebDavHandler;
import org.osgi.framework.BundleActivator;
import org.osgi.framework.BundleContext;

public class Activator implements BundleActivator {

    private WebDavHandler webDavHandler = null;

    @Override
    public void start(BundleContext bc) throws Exception {
        webDavHandler = WebDavHandler.getInstance();
        webDavHandler.setBundleContext(bc);
        webDavHandler.start();
    }

    @Override
    public void stop(BundleContext bc) throws Exception {
        if (webDavHandler != null) {
            webDavHandler.stopMilton();
        }
    }
}
