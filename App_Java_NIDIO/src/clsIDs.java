import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import static javax.swing.JOptionPane.showMessageDialog;


public class clsIDs {
        
        ResultSet rs;
        Connection con;
        Statement stmt;
        
    public void newID(String varUser, int varServ, String varDesc){
        try{   
            Class.forName("oracle.jdbc.driver.OracleDriver");   
            con = DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:orcl","system","Ali000");  
            stmt = con.createStatement();
            
            //tbIds
                rs = stmt.executeQuery("SELECT idUsr FROM tbUsr WHERE lgUsr = '" + varUser + "'");
                rs.next();
                    String idUsr = rs.getString(1);
                    int idSrv = varServ;
                    String dcIds = varDesc;

            //tvIdev
                rs = stmt.executeQuery("SELECT seq_Ids.NEXTVAL FROM DUAL");
                rs.next();
                    String idIds = rs.getString(1);            
                    String stIdev = "Pendente";
                clsData data = new clsData();
                    String dtIdev = data.value();
                    String acIdev = "";
            
            stmt.executeUpdate(
                "INSERT INTO tbIds(idIds, idUsr, idSrv, dcIds) "
                    + "VALUES(" + idIds + ", " + idUsr + ", " + idSrv + ", '" + dcIds + "')");
            stmt.executeUpdate(
                "INSERT INTO tbIdev(idIdev, idIds, idUsr, stIdev, dtIdev, acIdev) "
                    + "VALUES(seq_Idev.NEXTVAL, " + idIds + ", " + idUsr + ", '" + stIdev + "', '" + dtIdev + "', '" + acIdev + "')");            
            
            con.close();
                showMessageDialog(null, "Chamado enviado com sucesso, Aguarde o atendimento do mesmo!");
            
        }catch(ClassNotFoundException | SQLException e){
            showMessageDialog(null, "ERROR: (clsIds) - ("+ e +")!");
        }
    }
}
