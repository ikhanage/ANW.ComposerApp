var ComposerList = (function () {
    var setComposerCount = function (count) {
        var text = 'There was an error getting the composer count.';
        if (count != null) {
            switch(count){
                case 0:
                    text = 'There are no composers being displayed';
                    break;
                case 1:
                    text = 'There is ' + count + ' composer being displayed';
                    break;
                default:
                    text = 'There are ' + count + ' composers being displayed';
                    break;
            }
        }

        $('#composerCount').text(text);
    }

    return {
        SetComposerCount: setComposerCount
    }
})();