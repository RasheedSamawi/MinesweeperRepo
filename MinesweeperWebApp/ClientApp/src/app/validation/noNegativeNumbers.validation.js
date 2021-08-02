"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.NoNegativeNumbers = void 0;
function NoNegativeNumbers(control) {
    return control.value < 0 ? { negativeNumber: true } : null;
}
exports.NoNegativeNumbers = NoNegativeNumbers;
//# sourceMappingURL=noNegativeNumbers.validation.js.map