package red.itvirtuoso.island;

import io.vertx.core.AbstractVerticle;
import io.vertx.core.net.NetServer;

public class MainVerticle extends AbstractVerticle {

    @Override
    public void start() {
        for (int i = 0; i < 10; i++) {
            NetServer server = vertx.createNetServer();
            server.connectHandler(socket -> {
                socket.handler(buffer -> {
                    // Just echo back the data
                    socket.write(buffer);
                });
            });
            server.listen(1234, "localhost");
        }
    }
}
