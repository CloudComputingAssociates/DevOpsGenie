"use strict";
//main entry point
var platform_browser_dynamic_1 = require('@angular/platform-browser-dynamic');
var app_ng_module_js_1 = require('./src/app-ng.module.js');
platform_browser_dynamic_1.platformBrowserDynamic().bootstrapModule(app_ng_module_js_1.AppModule)
    .then(function (success) { return console.log('Bootstrap success'); })
    .catch(function (err) { return console.error(err); });
//# sourceMappingURL=main.js.map