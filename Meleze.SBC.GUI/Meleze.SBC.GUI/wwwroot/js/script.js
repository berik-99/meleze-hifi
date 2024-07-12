

window.JsFunctions = {
    addKeyboardListenerEvent: function (dotNetRef) {
        window.document.addEventListener('keyup', function (e) {
            dotNetRef.invokeMethodAsync('JsKeyPress', e.key);
        });
    }
};