<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
  <html>
  <body>
  <h2>Students</h2>
    <table border="1">
      <tr bgcolor="#9acd32">
        <th style="text-align:left">Name</th>
        <th style="text-align:left">F.N.</th>
        <th style="text-align:left">Sex</th>
        <th style="text-align:left">Birthday</th>
        <th style="text-align:left">Phone</th>
        <th style="text-align:left">Email</th>
        <th style="text-align:left">Course</th>
        <th style="text-align:left">Specialty</th>
      </tr>
      <xsl:for-each select="students/student">
      <tr>
        <td><xsl:value-of select="name"/></td>
        <td><xsl:value-of select="id"/></td>
        <td><xsl:value-of select="sex"/></td>
        <td><xsl:value-of select="birthDate"/></td>
        <td><xsl:value-of select="phone"/></td>
        <td><xsl:value-of select="email"/></td>
        <td><xsl:value-of select="course"/></td>
        <td><xsl:value-of select="specialty"/></td>
        <td><table> 
      </tr>
      </xsl:for-each>
    </table>
  </body>
  </html>
</xsl:template>
</xsl:stylesheet>

