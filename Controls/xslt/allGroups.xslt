<?xml version='1.0'?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="/">
<xsl:param name="Group" select="'A'"></xsl:param>
<HTML>
<LINK href="myFA.css" type="text/css" rel="stylesheet" />
<BODY>
<TABLE cellspacing="0" cellpadding="2" width="240" border="0">
<!-- <TR bgcolor="#cccccc"> -->
 <TR>

		<TD class="stats"></TD> 
		<TD class="stats"><B>Group <xsl:value-of select="$Group" /></B></TD>
		<TD class="stats"><B>P</B></TD>
		<TD class="stats"><B>W</B></TD>
		<TD class="stats"><B>D</B></TD>
		<TD class="stats"><B>L</B></TD>
		<TD class="stats"><B>F</B></TD>
		<TD class="stats"><B>A</B></TD>
		<TD class="stats"><B>Pts</B></TD>
		
	
</TR>

<xsl:apply-templates select="standings/round/group"> 
	<xsl:with-param name="Group" select="$Group"></xsl:with-param>
</xsl:apply-templates>

</TABLE>
</BODY>
</HTML>
</xsl:template>


<xsl:template match="standings/round/group">
	<xsl:param name="Group" />
		
		
		<xsl:if test="normalize-space($Group)=normalize-space(@name)">
		     
			 <xsl:apply-templates select="team"  />
	     
	
	</xsl:if>
	
</xsl:template>


<xsl:template name="SetFlagName">
	<xsl:param name="countyName"></xsl:param>
	<xsl:choose>
		<xsl:when test="$countyName='Netherlands'">Holland</xsl:when>
		<xsl:when test="$countyName='Czech Republic'">CzechRep</xsl:when>
		<xsl:otherwise><xsl:value-of select="$countyName"/></xsl:otherwise>
	</xsl:choose>
</xsl:template>

				
	
<xsl:template name="results" match="team">
	
	
	<tr class="rowcolor{position() mod 2}">
	
	<xsl:if test="(position() mod 2) = 0">
	<xsl:attribute name="class">rowcolor2</xsl:attribute>
	</xsl:if> 
	
	
	   <TD>
        
         <img>         
         <xsl:attribute name="src">\CmsUEFAfeeds\images\flag_<xsl:call-template name="SetFlagName">
         <xsl:with-param name="countyName" select="@name"/>
         </xsl:call-template>.gif</xsl:attribute>
         </img>   <!-- change Flag images location here for live site -->
       </TD>
             
      <TD valign="top" class="GroupTeamRed"><xsl:call-template name="SetFlagName">
      <xsl:with-param name="countyName" select="@name"/>
     
      </xsl:call-template></TD>  
        
	<TD class="ColouredBlock"><xsl:value-of select="played"/></TD>
	<TD class="ColouredBlock"><xsl:value-of select="won"/></TD>
	<TD class="ColouredBlock"><xsl:value-of select="drawn"/></TD>
	<TD class="ColouredBlock"><xsl:value-of select="lost"/> </TD>
	<TD class="ColouredBlock"><xsl:value-of select="scored"/></TD>
	<TD class="ColouredBlock"><xsl:value-of select="conceded"/></TD>  
	<TD class="ColouredBlock"><xsl:value-of select="points"/></TD>
	<!-- <TD><xsl:value-of select="standings/round/group[@name]"/></TD> -->

	</tr>
</xsl:template>
	
</xsl:stylesheet>










