"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.FetchDataService = void 0;
var core_1 = require("@angular/core");
var operators_1 = require("rxjs/operators");
core_1.Injectable();
var FetchDataService = /** @class */ (function () {
    function FetchDataService(http) {
        this.http = http;
    }
    FetchDataService.prototype.getPanel = function () {
        return this.http.get('/weatherforecast')
            .pipe(operators_1.map(function (res) { return res; }));
    };
    return FetchDataService;
}());
exports.FetchDataService = FetchDataService;
//# sourceMappingURL=fetch-data.service.js.map