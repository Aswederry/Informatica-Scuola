﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Il codice è stato generato da uno strumento.
'     Versione runtime:4.0.30319.42000
'
'     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
'     il codice viene rigenerato.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Questa classe è stata generata automaticamente dalla classe StronglyTypedResourceBuilder.
    'tramite uno strumento quale ResGen o Visual Studio.
    'Per aggiungere o rimuovere un membro, modificare il file con estensione ResX ed eseguire nuovamente ResGen
    'con l'opzione /str oppure ricompilare il progetto VS.
    '''<summary>
    '''  Classe di risorse fortemente tipizzata per la ricerca di stringhe localizzate e così via.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Restituisce l'istanza di ResourceManager nella cache utilizzata da questa classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Gioco_Oca.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Esegue l'override della proprietà CurrentUICulture del thread corrente per tutte le
        '''  ricerche di risorse eseguite utilizzando questa classe di risorse fortemente tipizzata.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property oca() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("oca", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property oca2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("oca2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property oca3() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("oca3", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property tabbella() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("tabbella", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property tabellone() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("tabellone", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
