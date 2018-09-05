import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import static javax.swing.JOptionPane.showMessageDialog;


public class clsUser {
    
    String login;
    String pass;
    String acesso;
    String nome;
    String data;
    String id;
    
    public void getUser(String varUser){
        try{   
            Class.forName("oracle.jdbc.driver.OracleDriver");   
            Connection con=DriverManager.getConnection("jdbc:oracle:thin:@localhost:1521:orcl","system","Ali000");  
            Statement stmt=con.createStatement();
            ResultSet rs=stmt.executeQuery("SELECT idUsr, pwUsr, idAcs, nmUsr, dtaUsr "
                                                + "FROM tbUsr WHERE lgUsr = '" + varUser + "'");
                rs.next();
                    
                login = varUser;
                id = rs.getString(1);
                pass = rs.getString(2);
                acesso = rs.getString(3);
                nome = rs.getString(4);
                data = rs.getString(5);
                
            con.close();

        }catch(ClassNotFoundException | SQLException e){
            showMessageDialog(null, "ERROR: (clsUser) - ("+ e +")!");
        }
    }
}
