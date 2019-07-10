 (function ($, cardDeck) {
    $(document).ready(function () {
        $("#shuffle").click(function () {
             $("#cardholder").empty(); // clear the contents of a "display" div tag                  

            var imagepath = cardDeck.dataArray;
            shuffle(imagepath);                      

            for (var i = 0; i < imagepath.length; i++) {
                $("#cardholder").append(
                    "<img src='" + imagepath[i] + "' width='76' height='117' hspace='3'/>"
                );
            }
        });
    });
 })($, cardDeck)

/* A shuffle function for an array */
function shuffle(o) {
    for (
        var j, x, i = o.length;
        i;
        j = parseInt(Math.random() * i), x = o[--i], o[i] = o[j], o[j] = x
    );
    return o;
}